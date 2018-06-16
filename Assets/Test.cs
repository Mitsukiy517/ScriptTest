using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;  //体力 
	private int power = 25; //攻撃力 
	private int mp = 53; //MP

	//攻撃用の関数 
	public void Attack() {
		Debug.Log (this.power + "ダメージを与えた");
	}

	//防御用の関数 
	public void Defence(int damage) {
		Debug.Log (damage + "のダメージを受けた");
		//残りhpを減らす 
		this.hp -= damage;
	}

	//魔法攻撃用の関数
	public void Magic(){
		
		//魔法攻撃を行った場合
		if (this.mp >= 5) {
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");

		//MPが足りなかった場合
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

}

public class Test : MonoBehaviour {

	private int[] array = {2, 3, 5, 7, 11};

	//配列を表示する関数 
	public void ArrayPrint(bool flag){
		
		//配列arrayを順番に表示
		if (flag == true) {
			Debug.Log ("配列arrayを順番に表示");
			for (int i = 0; i < array.Length; i++) {
				Debug.Log (this.array [i]);
			}

		//配列arrayを逆順に表示
		} else if (flag == false) {
			Debug.Log ("配列arrayを逆順に表示");
			for (int i = array.Length-1; i >= 0; i--) {
				Debug.Log (this.array [i]);
			}

		}
	}

	// Use this for initialization 
	void Start () {
		
		//Bossクラスの変数を宣言してインスタンスを代入 
		Boss lastboss = new Boss ();

		//配列arrayを順番に表示 
		ArrayPrint(true); 

		//配列arrayを逆順に表示 
		ArrayPrint(false);

		//攻撃用の関数を呼び出す 
		lastboss.Attack ();
		//防御用の関数を呼びだす 
		lastboss.Defence (3);

		//魔法攻撃用の関数を11回呼び出す
		for (int i = 0; i < 11; i++) {
			lastboss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
