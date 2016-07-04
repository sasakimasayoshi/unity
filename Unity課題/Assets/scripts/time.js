#pragma strict

private var minite : int;
private var second : float;
private var oldSecond : int;
private var timerFlag : boolean = true;
private var textField : UI.Text;
function Start () {
 minite = 0;
 second = 0;
 oldSecond = 0;
 textField = GetComponent(UI.Text);
}
function Update () {
 if(Time.timeScale > 0) {
  second += Time.deltaTime;
  if(second >= 60.0f) {
   minite++;
   second = second - 60;
  }
  if(parseInt(second) != oldSecond) {
   textField.text = minite.ToString("Time 00") + ":" + parseInt(second).ToString("00");
  }
  oldSecond = parseInt(second);
 }
}
