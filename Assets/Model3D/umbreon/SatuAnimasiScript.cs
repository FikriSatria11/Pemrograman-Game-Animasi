using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class SatuAnimasiScript : MonoBehaviour
{
	
	Animator anim;
	Animator Animation;
	public int Speed;
	public int Jumping;
	Rigidbody2D Jump;
    // Start is called before the first frame update
    void Start(){
        anim = GetComponent<Animator>();
		Animation = GetComponent<Animator> ();
		Jump = GetComponent<Rigidbody2D> ();
    }
    
	
    // Update is called once per frame
    void Update(){
		
		if (Input.GetKey (KeyCode.A)) { // Fungsi untuk mendapatkan kode Keyboard A.
			transform.Translate (Vector2.left * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kiri sesuai dengan kecepatan input.
		} else if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.Space)) { // Fungsi jika kode Keyboard yang di gunakan A dan Spasi maka tetap menerapkan fungsi gerak ke kiri.
			transform.Translate (Vector2.left * Speed * Time.deltaTime);//Fungsi untuk gerakan karakter ke kiri sesuai dengan kecepatan input.
			Animation.SetBool ("Walk Pocong", true); // Fungsi untuk menyalakan animasi berjalan.
		} else { // Fungsi jika kondisi yang di hadapi selain Keyboard A dan Keyboard A+Spasi.
			Animation.SetBool ("Walk Pocong", false); // Fungsi untuk mematikan animasi berjalan.
		}
		
		if (Input.GetKey (KeyCode.D)) { // Fungsi untuk mendapatkan kode Keyboard D.
			transform.Translate (Vector2.right * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kanan sesuai dengan kecepatan input.
			Animation.SetBool ("Walk Pocong", true); // Fungsi untuk menyalakan animasi berjalan.
		} else if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.Space)) { // Fungsi jika kode Keyboard yang di gunakan D dan Spasi maka tetap menerapkan fungsi gerak ke kanan.
			transform.Translate (Vector2.right * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kanan sesuai dengan kecepatan input.
			Animation.SetBool ("Walk Pocong", true); // Fungsi untuk menyalakan animasi berjalan.
		} else { // Fungsi jika kondisi yang di hadapi selain Keyboard D dan Keyboard D+Spasi.
			Animation.SetBool ("Walk Pocong", false); // Fungsi untuk mematikan animasi berjalan.
		}
		
		if (Input.GetKey (KeyCode.W)) { // Fungsi untuk mendapatkan kode Keyboard D.
			transform.Translate (Vector2.up * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kanan sesuai dengan kecepatan input.
			Animation.SetBool ("Walk Pocong", true); // Fungsi untuk menyalakan animasi berjalan.
		} else if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.Space)) { // Fungsi jika kode Keyboard yang di gunakan D dan Spasi maka tetap menerapkan fungsi gerak ke kanan.
			transform.Translate (Vector2.up * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kanan sesuai dengan kecepatan input.
			Animation.SetBool ("Walk Pocong", true); // Fungsi untuk menyalakan animasi berjalan.
		} else { // Fungsi jika kondisi yang di hadapi selain Keyboard D dan Keyboard D+Spasi.
			Animation.SetBool ("Walk Pocong", false); // Fungsi untuk mematikan animasi berjalan.
		}
		
		if (Input.GetKey (KeyCode.S)) { // Fungsi untuk mendapatkan kode Keyboard D.
			transform.Translate (Vector2.down * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kanan sesuai dengan kecepatan input.
			Animation.SetBool ("Walk Pocong", true); // Fungsi untuk menyalakan animasi berjalan.
		} else if (Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.Space)) { // Fungsi jika kode Keyboard yang di gunakan D dan Spasi maka tetap menerapkan fungsi gerak ke kanan.
			transform.Translate (Vector2.down * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kanan sesuai dengan kecepatan input.
			Animation.SetBool ("Walk Pocong", true); // Fungsi untuk menyalakan animasi berjalan.
		} else { // Fungsi jika kondisi yang di hadapi selain Keyboard D dan Keyboard D+Spasi.
			Animation.SetBool ("Walk Pocong", false); // Fungsi untuk mematikan animasi berjalan.
		}
		
		
		if (Input.GetKey (KeyCode.Space)) { // Fungsi untuk mendapatkan kode Keyboard Space.
			Jump.AddForce (new Vector2 (1, Jumping)); //Fungsi untuk melompat menggunakan Vector 2 dengan kecepatan input Jumping.
			Animation.SetBool ("Jump Pocong", true); // Fungsi untuk menyalakan animasi melompat.
		}  else { // Fungsi jika kondisi yang di hadapi selain Keyboard Space.
			Animation.SetBool ("Jump Pocong", false); // Fungsi untuk mematikan animasi melompat.
		}
		
		if(Input.GetKeyDown(KeyCode.O)){
			anim.SetTrigger("Animasi Jalan");
		}
                               
		if(Input.GetKeyDown(KeyCode.P)){
			anim.SetTrigger("Animasi Lari");
		}
    }
}
