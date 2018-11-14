using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct CUSTOM_VERTEX
{
    public float _x, _y, _z;
    public Color _color;

    public CUSTOM_VERTEX(float x, float y, float z, Color color)
    {
        _x = x;
        _y = y;
        _z = z;
        _color = color;
    }
}

//버텍스와 노말 텍스쳐좌표를 받는 버텍스 구조체
public struct TEX_VERTEX
{
    public float _x, _y, _z;
    public float _nx, _ny, _nz;
    public float _u, _v;

    public TEX_VERTEX(float x, float y, float z, float nx, float ny, float nz, float u, float v)
    {
        _x = x;
        _y = y;
        _z = z;

        _nx = nx;
        _ny = ny;
        _nz = nz;

        _u = u;
        _v = v;
    }
}
