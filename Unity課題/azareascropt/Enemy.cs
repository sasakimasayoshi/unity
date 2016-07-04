using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	GameObject target;
	
	public GameObject shot;

	float shotInterval = 0;
	float shotIntervalMax = 1.0F;
	
	public GameObject exprosion;
	
	public int armorPoint;
	public int armorPointMax = 1000; 
	int damage = 100;
	
	// Use this for initialization
	void Start () {
	
		//ターゲットを取得
		target = GameObject.Find("PlayerTarget");
		
		armorPoint = armorPointMax;
	}
	
	// Update is called once per frame
	void Update () {
	
		//敵の攻撃範囲を設定する
		if( Vector3.Distance (target.transform.position, transform.position) <= 30 ){
			
			//ターゲットの方向を向く
			//transform.LookAt(target.transform);
			
			//スムーズにターゲットの方向を向く
			Quaternion targetRotation = Quaternion.LookRotation (target.transform.position - transform.position);
			transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, Time.deltaTime * 10);
			
			//弾を発射する
			shotInterval += Time.deltaTime;
			
			if(shotInterval > shotIntervalMax){

				Instantiate(shot, transform.position, transform.rotation);
				shotInterval = 0;
			}
		}
	}
	
	private void OnCollisionEnter(Collision collider) {

		
		if (collider.gameObject.tag == "Shot") {

			//プレイヤーの弾と衝突したら消滅する
			//Destroy (gameObject);
			//Instantiate(exprosion, transform.position, transform.rotation);
			
			//ダメージをランダムで変える
			//damage = Random.Range(50, 150);
			
			//プレイヤーの弾からダメージを取得する
			damage = collider.gameObject.GetComponent<ShotPlayer>().damage;
			
			//プレイヤーの弾と衝突したらダメージ
			armorPoint -= damage;

			//体力が0以下になったら消滅する
			if (armorPoint <= 0){
				Destroy (gameObject);
				Instantiate(exprosion, transform.position, transform.rotation);
			}
		}
		

	}
}
