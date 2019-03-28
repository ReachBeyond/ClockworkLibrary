using UnityEngine;

namespace ReachBeyond.VariableObjects {

	[CreateAssetMenu(menuName="Variable/Some")]
	public class SomeVariable : Base.StructVariable<int> {}

	[System.Serializable]
	public class SomeReference : Base.Reference<int, SomeVariable> {}

	[System.Serializable]
	public class SomeConstReference : Base.ConstReference<int, SomeVariable> {}

}


/* DO NOT REMOVE -- START VARIABLE OBJECT INFO -- DO NOT REMOVE **
{
    "name": "Some",
    "type": "int",
    "referability": "Struct"
}
** DO NOT REMOVE --  END VARIABLE OBJECT INFO  -- DO NOT REMOVE */
