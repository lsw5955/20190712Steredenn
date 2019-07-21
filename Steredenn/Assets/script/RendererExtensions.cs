using UnityEngine;

public static class RendererExtensions
{
    public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
    {
        Plane[] plane = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(plane, renderer.bounds);
    }
}
