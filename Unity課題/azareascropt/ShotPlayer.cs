﻿using UnityEngine;
using System.Collections;

public class ShotPlayer : MonoBehaviour {

	public GameObject explosion;
	
	public int damage = 200;
	
	// Use this for initialization
	void Start () {
	
		//現後一定時間で自動的に消滅させる
		Destroy(gameObject, 2.0F);
	}
	
	// Update is called once per frame
	void Update () {
	
		//弾を前進させる
		transform.position += transform.forward * Time.deltaTime * 100;
		
		//威力減衰 最少でも1ダメージは与える
		damage --;
		if(damage <= 1)
			damage = 1;
	}
	
	private void OnCollisionEnter(Collision collider) {

		//地形とぶつかったら消滅させる
		if(collider.gameObject.name == "Terrain") {

			Destroy(gameObject);
			Instantiate(explosion, transform.position, transform.rotation);
		}
		
		//敵と衝突したら消滅させる
		if(collider.gameObject.tag == "Enemy") {

			Destroy(gameObject);
		
			//衝突時に爆発エフェクトを表示する
			Instantiate(explosion, transform.position, transform.rotation);
		}
	}
}
