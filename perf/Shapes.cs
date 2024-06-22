using System.Runtime.CompilerServices;

public struct Shape
{
    public ShapeType Type { get; init; }
    public float Width { get; init; }
    public float Height { get; init; }
    private static readonly float[] modifier = {
        1.0f, 
        1.0f,
        0.5f,
        (float) Math.PI
    };

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float Area() {
        float modifier = Shape.modifier[(ushort)this.Type];
        return modifier * this.Width * this.Height;
        // Below is about 8x slower
        // switch (this.Type) {
        //     case ShapeType.Square :
        //         return widthWidth;                
        //     case ShapeType.Rectangle:
        //         return widthHeight;                
        //     case ShapeType.Triangle:
        //         return widthHeight * 0.5f;
        //     case ShapeType.Circle:
        //         return (float)Math.PI * widthHeight;                
        // }
        // return 0.0f;
    }
}
