using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator: MonoBehaviour {
	
	//carprefrabを入れる
	public GameObject carPrefab;
	//coinprefabを入れる
	public GameObject coinPrefab;
	//coneprefabを入れる
	public GameObject conePrefab;
	//スタート地点
	private int startPos = -160;
	//ゴール地点

	private int goalPos = 120;
	//アイテムをだすX方向の範囲
	private float posRange = 3.4f;


	// Use this for initialization
	void Start () {

		for (int i = startPos; i < goalPos; i += 15) {
			//一定距離ごとにアイテムを生成
			int num = Random.Range (1, 11);
			//どのアイテムをだすかランダムに設定
			if (num <= 2) {

				for (float j = -1; j <= 1; j += 0.4f) {
					//コーンをX軸に一直線に生成
					GameObject cone = Instantiate (conePrefab) as GameObject;

					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);

				}
			} else {

				for (int j = -1; j <= 1; j++) {
					//レーンごとにアイテムを生成
					int item = Random.Range (1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range (-5, 6);
					//60%コイン３０％車１０％何もなし
					if (1 <= item && item <= 6) {

						GameObject coin = Instantiate (coinPrefab) as GameObject;
						//コインを生成
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);

					} else if (7 <= item && item <= 9) {

						GameObject car = Instantiate (carPrefab) as GameObject;
						//車を生成
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
					}
				}
			}
		}
						
		
	}
	
	// Update is called once per frame
	void Update () {
	}



}
