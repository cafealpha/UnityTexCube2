using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTexCube : MonoBehaviour {
    public Texture tex;

    // Use this for initialization
    void Start()
    {
        //버텍스 정의
        CUSTOM_VERTEX[] vt ={
            //윗면
            new CUSTOM_VERTEX(-1f, 1f, 1f, new Color(1,0,1,1)),
            new CUSTOM_VERTEX(1f,1f,1f, new Color(0,1,0,1)),
            new CUSTOM_VERTEX(1f,1f,-1f, new Color(0,0,1,1)),

            new CUSTOM_VERTEX(-1f, 1f, 1f, new Color(1,0,1,1)),
            new CUSTOM_VERTEX(1f,1f,-1f, new Color(0,0,1,1)),
            new CUSTOM_VERTEX(-1f,1f,-1f, new Color(1,1,0,1)),
                       
            //아랫면
            new CUSTOM_VERTEX(-1f,-1f,1f, new Color(1,0,0,1)),
            new CUSTOM_VERTEX(1f,-1f,-1f, new Color(0,0,1,1)),
            new CUSTOM_VERTEX(1f,-1f,1f, new Color(0,1,0,1)),

            new CUSTOM_VERTEX(-1f,-1f,1f, new Color(1,0,0,1)),
            new CUSTOM_VERTEX(-1f,-1f,-1f, new Color(1,0,0,1)),
            new CUSTOM_VERTEX(1f,-1f,-1f, new Color(0,0,1,1)),

            //왼쪽면
            new CUSTOM_VERTEX(-1f, 1f, 1f, new Color(1,0,1,1)),
            new CUSTOM_VERTEX(-1f,1f,-1f, new Color(1,1,0,1)),
            new CUSTOM_VERTEX(-1f,-1f,-1f, new Color(1,0,0,1)),

            new CUSTOM_VERTEX(-1f, 1f, 1f, new Color(1,0,1,1)),
            new CUSTOM_VERTEX(-1f,-1f,-1f, new Color(1,0,0,1)),
            new CUSTOM_VERTEX(-1f,-1f,1f, new Color(1,0,0,1)),

            //오른쪽면
            new CUSTOM_VERTEX(1f,1f,1f, new Color(0,1,0,1)),
            new CUSTOM_VERTEX(1f,-1f,1f, new Color(0,1,0,1)),
            new CUSTOM_VERTEX(1f,-1f,-1f, new Color(0,0,1,1)),

            new CUSTOM_VERTEX(1f,1f,1f, new Color(0,1,0,1)),
            new CUSTOM_VERTEX(1f,-1f,-1f, new Color(0,0,1,1)),
            new CUSTOM_VERTEX(1f,1f,-1f, new Color(0,0,1,1)),

            //앞면
            new CUSTOM_VERTEX(-1f,1f,-1f, new Color(1,1,0,1)),
            new CUSTOM_VERTEX(1f,1f,-1f, new Color(0,0,1,1)),
            new CUSTOM_VERTEX(1f,-1f,-1f, new Color(0,0,1,1)),

            new CUSTOM_VERTEX(-1f,1f,-1f, new Color(1,1,0,1)),
            new CUSTOM_VERTEX(1f,-1f,-1f, new Color(0,0,1,1)),
            new CUSTOM_VERTEX(-1f,-1f,-1f, new Color(1,0,0,1)),

            //뒷면
            new CUSTOM_VERTEX(-1f, 1f, 1f, new Color(1,0,1,1)),
            new CUSTOM_VERTEX(-1f,-1f,1f, new Color(1,0,0,1)),
            new CUSTOM_VERTEX(1f,-1f,1f, new Color(0,1,0,1)),

            new CUSTOM_VERTEX(-1f, 1f, 1f, new Color(1,0,1,1)),
            new CUSTOM_VERTEX(1f,-1f,1f, new Color(0,1,0,1)),
            new CUSTOM_VERTEX(1f,1f,1f, new Color(0,1,0,1)),
        };


        //uv 세팅
        Vector2[] uv = new Vector2[vt.Length];
        //윗면
        uv[0] = new Vector2(0.25f, 0.50f);
        uv[1] = new Vector2(0.50f, 0.50f);
        uv[2] = new Vector2(0.50f, 0.0f);

        uv[3] = new Vector2(0.25f, 0.50f);
        uv[4] = new Vector2(0.50f, 0.0f);
        uv[5] = new Vector2(0.25f, 0.0f);

        //아랫면
        uv[6] = new Vector2(0.25f, 0.5f);
        uv[7] = new Vector2(0.5f, 0.75f);
        uv[8] = new Vector2(0.5f, 0.5f);

        uv[9] = new Vector2(0.25f, 0.5f);
        uv[10] = new Vector2(0.25f, 0.75f);
        uv[11] = new Vector2(0.5f, 0.75f);

        //왼쪽면
        uv[12] = new Vector2(0, 0.75f);
        uv[13] = new Vector2(0, 0.5f);
        uv[14] = new Vector2(0.25f, 0.5f);

        uv[15] = new Vector2(0, 0.75f);
        uv[16] = new Vector2(0.25f, 0.5f);
        uv[17] = new Vector2(0.25f, 0.75f);

        //오른쪽면
        uv[18] = new Vector2(0.75f, 0.75f);
        uv[19] = new Vector2(0.5f, 0.75f);
        uv[20] = new Vector2(0.5f, 0.5f);

        uv[21] = new Vector2(0.75f, 0.75f);
        uv[22] = new Vector2(0.5f, 0.5f);
        uv[23] = new Vector2(0.75f, 0.5f);

        //앞면
        uv[24] = new Vector2(0.25f, 1);
        uv[25] = new Vector2(0.5f, 1);
        uv[26] = new Vector2(0.5f, 0.75f);

        uv[27] = new Vector2(0.25f, 1);
        uv[28] = new Vector2(0.5f, 0.75f);
        uv[29] = new Vector2(0.25f, 0.75f);

        //뒷면
        uv[30] = new Vector2(0.25f, 0.25f);
        uv[31] = new Vector2(0.25f, 0.5f);
        uv[32] = new Vector2(0.5f, 0.5f);

        uv[33] = new Vector2(0.25f, 0.25f);
        uv[34] = new Vector2(0.5f, 0.5f);
        uv[35] = new Vector2(0.5f, 0.25f);


        ////큐브를 만들때는 인덱스를 사용한다.12개의 면
        //int[] triangles =
        //{
        //    0,1,2, 0,2,3,        //윗면
        //    4,6,5, 4,7,6,       //아랫면
        //    0,3,7, 0,7,4,       //왼쪽면
        //    1,5,6, 1,6,2,       //오른쪽면
        //    3,2,6, 3,6,7,       //앞면
        //    0,4,5, 0,5,1,       //뒷면
        //};

        //인덱스 관리 없이 바로 1:1대입
        int[] triangles = new int[vt.Length];
        for(int i = 0; i < vt.Length; i++)
        {
            triangles[i] = i;
        }

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
        tex = Resources.Load("Image/amazonboxTx") as Texture;

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
        obj.name = "TexCube";

        //매쉬 필터와 렌더러를 붙여주고 캐시함
        MeshFilter mf = obj.AddComponent<MeshFilter>();
        MeshRenderer mr = obj.AddComponent<MeshRenderer>();
        //매쉬 필터에 적용
        mf.mesh = mesh;
        //머티리얼 적용
        Material mat = new Material(Shader.Find("Custom/BasicTextureShader"));
        mat.mainTexture = tex;

        mr.material = mat;

        obj.transform.Translate(new Vector3(0, 1, 0));

        //Instantiate(obj);

    }
}
