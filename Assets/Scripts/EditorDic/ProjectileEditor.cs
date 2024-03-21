using System;
using UnityEditor;
using UnityEngine;

namespace EditorDic
{
    [CustomEditor(typeof(Launcher))]
    public class ProjectileEditor : Editor
    {
        
        [DrawGizmo(GizmoType.Selected | GizmoType.NonSelected)]
        static void  OnDrawGizmos (Projectile projectile, GizmoType gizmoType)
        {
            Gizmos.DrawSphere(projectile.transform.position,0.125f);
        }
        private void OnSceneGUI()
        {
            Projectile projectile = target as Projectile;
            var transform = projectile.transform;
            projectile.damageRadius = Handles.RadiusHandle(
                transform.rotation, 
                transform.position, 
                projectile.damageRadius);
            
        }
    }
}