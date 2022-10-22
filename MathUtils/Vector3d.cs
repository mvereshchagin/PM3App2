namespace MathUtils;

/// <summary>
/// Vector3d class
/// </summary>
/// <param name="X">X projection</param>
/// <param name="Y">Y projection</param>
/// <param name="Z">Z projection</param>
public record struct Vector3d(int X, int Y, int Z)
{
    #region ctor
    /// <summary>
    /// ctor of Vector3d
    /// </summary>
    /// <param name="pointA">start point</param>
    /// <param name="pointB">end point</param>
    public Vector3d(Point3d pointA, Point3d pointB) : 
        this(pointB.X - pointA.X, pointB.Y - pointA.Y, pointB.Z - pointA.Z)
    { }
    #endregion
    
    #region props
    /// <summary>
    /// Length of vector
    /// </summary>
    public float Length => MathF.Sqrt(X * X + Y * Y + Z * Z);
    #endregion

    #region methods
    /// <summary>
    /// Dot product
    /// </summary>
    /// <param name="vector1">vector 1</param>
    /// <param name="vector2">vector 2</param>
    /// <returns>result of dot product</returns>
    public static float DotProduct(Vector3d vector1, Vector3d vector2)
    {
        return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z;
    }
    
    /// <summary>
    /// Cross product
    /// </summary>
    /// <param name="a">vector 1</param>
    /// <param name="b">vector 2</param>
    /// <returns>result of cross product</returns>
    public static Vector3d CrossProduct(Vector3d a, Vector3d b)
    {
        return new Vector3d()
        {
            X = a.Y * b.Z - a.Z * b.Y,
            Y = a.Z * b.X - a.X * b.Z,
            Z = a.X * b.Y - a.Y * b.X
        };
    }

    /// <summary>
    /// Mixed product
    /// </summary>
    /// <param name="a">vector 1</param>
    /// <param name="b">vector 2</param>
    /// <param name="c">vector 3</param>
    /// <returns>result of mixed product</returns>
    public static float MixedProduct(Vector3d a, Vector3d b, Vector3d c)
    {
        return a.X * b.Y * c.Z + 
               a.Y * b.Z * c.X + 
               a.Z * b.X * c.Y - 
               a.Z * b.Y * c.Z - 
               a.X * b.Z * c.Y -
               a.Y * b.X * c.Z;
    }

    /// <summary>
    /// Shifts the vector
    /// </summary>
    /// <param name="x">shift along x axis</param>
    /// <param name="y">shift along y axis</param>
    /// <param name="z">shift along z axis</param>
    public void Shift(int x = 0, int y = 0, int z = 0)
    {
        X += x;
        Y += y;
        Z += z;
    }

    public void RotateZ(float angle)
    {
        
    }

    #endregion

    #region operators
    public static bool operator > (Vector3d a, Vector3d b) => a.Length > b.Length;
    public static bool operator < (Vector3d a, Vector3d b) => !(a > b);
    public static float operator *(Vector3d a, Vector3d b) => DotProduct(a, b);
    public static Vector3d operator +(Vector3d a, Vector3d b) => new Vector3d(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    public static Vector3d operator -(Vector3d a, Vector3d b) => new Vector3d(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    #endregion

    #region overridden
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
    #endregion
    
    
}