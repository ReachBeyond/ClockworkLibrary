using UnityEngine;
using UnityEditor;

namespace ReachBeyond.VariableObjects.Editor {

	[CustomPropertyDrawer(typeof(SomeReference))]
	public class SomeRefEditor : Base.Editor.RefEditor { }

	[CustomPropertyDrawer(typeof(SomeConstReference))]
	public class SomeConstRefEditor : Base.Editor.ConstRefEditor { }
}


/* DO NOT REMOVE -- START VARIABLE OBJECT INFO -- DO NOT REMOVE **
{
    "name": "Some",
    "type": "int",
    "referability": "Struct"
}
** DO NOT REMOVE --  END VARIABLE OBJECT INFO  -- DO NOT REMOVE */
