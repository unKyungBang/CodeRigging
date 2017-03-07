using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSkinnedMesh : MonoBehaviour
{

    public Material Mat;
    public Transform[] bones;
    // Use this for initialization
    void Start()
    {
        Mesh m = new Mesh();
        SkinnedMeshRenderer smr = GetComponent<SkinnedMeshRenderer>();

        m.vertices = new Vector3[]
       {

            // Head 
            new Vector3(0.0f,0.0f,0.0f),
            new Vector3(-5.0f,5.0f,0.0f),
            new Vector3(5.0f,5.0f,0.0f),
            // Body
            new Vector3(-5.0f,-10.0f,0.0f),
            new Vector3(-5.0f,0.0f,0.0f),
            new Vector3(5.0f,0.0f,0.0f),
            new Vector3(5.0f,-10.0f,0.0f),
            // Left Shoulder
            new Vector3(-9.0f,-2.0f,0.0f),
            new Vector3(-9.0f,0.0f,0.0f),
            new Vector3(-5.0f,0.0f,0.0f),
            new Vector3(-5.0f,-2.0f,0.0f),
            // Right Shoulder
            new Vector3(5.0f,-2.0f,0.0f),
            new Vector3(5.0f,0.0f,0.0f),
            new Vector3(9.0f,0.0f,0.0f),
            new Vector3(9.0f,-2.0f,0.0f),
            // Left Arm
            new Vector3(-9.0f,-10.0f,0.0f),
            new Vector3(-9.0f,-2.0f,0.0f),
            new Vector3(-7.0f,-2.0f,0.0f),
            new Vector3(-7.0f,-10.0f,0.0f),
            // Right Arms
            new Vector3(7.0f,-10.0f,0.0f),
            new Vector3(7.0f,-2.0f,0.0f),
            new Vector3(9.0f,-2.0f,0.0f),
            new Vector3(9.0f,-10.0f,0.0f),
            // Left Hand
            new Vector3(-8.0f,-11.0f,0.0f),
            new Vector3(-9.0f,-10.0f,0.0f),
            new Vector3(-7.0f,-10.0f,0.0f),
            // Right Hand
            new Vector3(8.0f,-11.0f,0.0f),
            new Vector3(7.0f,-10.0f,0.0f),
            new Vector3(9.0f,-10.0f,0.0f),
            // Left Leg
            new Vector3(-5.0f,-20.0f,0.0f),
            new Vector3(-5.0f,-10.0f,0.0f),
            new Vector3(-3.0f,-10.0f,0.0f),
            new Vector3(-3.0f,-20.0f,0.0f),
            // Right Leg
            new Vector3(3.0f,-20.0f,0.0f),
            new Vector3(3.0f,-10.0f,0.0f),
            new Vector3(5.0f,-10.0f,0.0f),
            new Vector3(5.0f,-20.0f,0.0f),
            // Left Foot
            new Vector3(-7.0f,-22.0f,0.0f),
            new Vector3(-7.0f,-20.0f,0.0f),
            new Vector3(-3.0f,-20.0f,0.0f),
            new Vector3(-3.0f,-22.0f,0.0f),
            // Right Foot
            new Vector3(3.0f,-22.0f,0.0f),
            new Vector3(3.0f,-20.0f,0.0f),
            new Vector3(7.0f,-20.0f,0.0f),
            new Vector3(7.0f,-22.0f,0.0f),
            // Left Horn
            new Vector3(-5.0f,5.0f,0.0f),
            new Vector3(-5.0f,10.0f,0.0f),
            new Vector3(-3.0f,10.0f,0.0f),
            new Vector3(-3.0f,5.0f,0.0f),
            // Right Horn
            new Vector3(3.0f,5.0f,0.0f),
            new Vector3(3.0f,10.0f,0.0f),
            new Vector3(5.0f,10.0f,0.0f),
            new Vector3(5.0f,5.0f,0.0f),
            // Left Ear
            new Vector3(-7.0f,3.0f,0.0f),
            new Vector3(-7.0f,7.0f,0.0f),
            new Vector3(-3.0f,3.0f,0.0f),
            // Right Ear
            new Vector3(3.0f,3.0f,0.0f),
            new Vector3(7.0f,3.0f,0.0f),
            new Vector3(7.0f,7.0f,0.0f),
    };

        m.triangles = new int[] {
            // Head
            0, 1, 2 ,
            // Body 
            3,4,5, 3,5,6,
            // Left Shoulder
            7,8,9, 7,9,10,
            // Right Shoulder
            11,12,13 , 11,13,14,
            // Left Arm
            15,16,17 , 15,17,18,
            // Right Arm
            19,20,21 , 19,21,22,
            // Left Hand
            23,24,25,
            // Right Hand
            26,27,28,
            // Left Leg
            29,30,31 , 29,31,32,
            // Right Leg
            33,34,35 , 33,35,36,
            // Left Foot
            37,38,39 , 37,39,40,
            // Right Foot
            41,42,43 , 41,43,44,
            // Left Horn
            45,46,47 , 45,47,48,
            // Right Horn
            49,50,51 , 49,51,52,
            // Ear
            53,54,55 , 56,57,58
        };
        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix * transform.worldToLocalMatrix,
            bones[1].worldToLocalMatrix * transform.worldToLocalMatrix,
        };

        m.boneWeights = new BoneWeight[]
        {
            // Head Bone
            new BoneWeight() {boneIndex0 = 0, weight0 = 1f  },
            new BoneWeight() {boneIndex0 = 1, weight0 = 0.8f  },
            new BoneWeight() {boneIndex0 = 0, weight0 = 1f},
            // Body Bond
            new BoneWeight() { boneIndex0 = 0,weight0 = 1f },
            new BoneWeight() { boneIndex0 = 0,weight0 = 1f },
            new BoneWeight() { boneIndex0 = 0,weight0 = 1f },
            new BoneWeight() { boneIndex0 = 0,weight0 = 1f }
        };
        smr.sharedMesh = m;
        smr.sharedMaterial = Mat;
        smr.bones = bones;
        smr.rootBone = this.transform;
        smr.quality = SkinQuality.Bone1;


    }

    // Update is called once per frame
    void Update()
    {

    }
}
