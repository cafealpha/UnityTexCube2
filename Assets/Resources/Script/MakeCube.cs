using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCube : MonoBehaviour {
    public Texture tex;

    // Use this for initialization
    void Start()
    {
        //버텍스 정의
        CUSTOM_VERTEX[] vt ={
            new CUSTOM_VERTEX(-1f, 1f, 1f, new Color(1,0,1,1)),
            new CUSTOM_VERTEX(1f,1f,1f, new Color(0,1,0,1)),
            new CUSTOM_VERTEX(1f,1f,-1f, new Color(0,0,1,1)),
            new CUSTOM_VERTEX(-1f,1f,-1f, new Color(1,1,0,1)),

            new CUSTOM_VERTEX(-1f,-1f,1f, new Color(1,0,0,1)),
            new CUSTOM_VERTEX(1f,-1f,1f, new Color(0,1,0,1)),
            new CUSTOM_VERTEX(1f,-1f,-1f, new Color(0,0,1,1)),
            new CUSTOM_VERTEX(-1f,-1f,-1f, new Color(1,0,0,1)),
        };
        //uv 세팅
        Vector2[] uv = new Vector2[vt.Length];
        uv[0] = new Vector2(0, 1); //0,1,2
        uv[1] = new Vector2(1, 1);
        uv[2] = new Vector2(1, 0);
        uv[3] = new Vector2(0, 0); //0,2,3

        uv[4] = new Vector2(0, 1);
        uv[5] = new Vector2(1, 1);
        uv[6] = new Vector2(1, 0); //0,1,2
        uv[7] = new Vector2(0, 0);



        //큐브를 만들때는 인덱스를 사용한다.12개의 면
        int[] triangles =
        {
            0,1,2, 0,2,3,        //윗면
            4,6,5, 4,7,6,       //아랫면
            0,3,7, 0,7,4,       //왼쪽면
            1,5,6, 1,6,2,       //오른쪽면
            3,2,6, 3,6,7,       //앞면
            0,4,5, 0,5,1,       //뒷면
        };

        //노말과 버텍스 컬러는 입력할 필요 없다.
        //노말은 이미 버텍스 구조체 안에 들어있음.

        //버텍스 리스트 추출
        Vector3[] vtl = new Vector3[vt.Length];
        for (int i = 0; i < vt.Length; i++)
        {
            vtl[i] = new Vector3(vt[i]._x, vt[i]._y, vt[i]._z);
        }
        //버텍스 컬러 추출
        Color[] vc = new Color[vt.Length];
        for (int i = 0; i < vt.Length; i++)
        {
            vc[i] = vt[i]._color;
        }


        ////노말 추출
        //Vector3[] nl = new Vector3[vt.Length];
        //for (int i = 0; i < vt.Length; i++)
        //{
        //    nl[i] = new Vector3(vt[i]._nx, vt[i]._ny, vt[i]._nz);
        //}



        ////텍스쳐 로드
        //tex = null;
        //tex = Resources.Load("Image/amazonbox") as Texture;

        //매쉬 생성
        Mesh mesh = new Mesh();
        mesh.vertices = vtl;
        mesh.triangles = triangles;
        mesh.colors = vc;
        //mesh.normals = nl;
        mesh.uv = uv;


        mesh.RecalculateNormals();

        //인스턴스화할 게임오브젝트를 만듬.        
        GameObject obj = new GameObject();
        obj.name = "Cube";

        //매쉬 필터와 렌더러를 붙여주고 캐시함
        MeshFilter mf = obj.AddComponent<MeshFilter>();
        MeshRenderer mr = obj.AddComponent<MeshRenderer>();
        //매쉬 필터에 적용
        mf.mesh = mesh;
        //머티리얼 적용
        Material mat = new Material(Shader.Find("Custom/BasicShader"));
        mat.mainTexture = tex;

        mr.material = mat;
        //Instantiate(obj);

    }
}
