using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject[] vfxSource;

    public void PlayVFX(Vector3 spawnPosition, int vfxIndex)
	{
		if(vfxIndex >= 0 && vfxIndex < vfxSource.Length)
		{
			Instantiate(vfxSource[vfxIndex], spawnPosition, Quaternion.identity);
		}
	}
}
