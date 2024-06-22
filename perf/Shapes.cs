using System.Runtime.CompilerServices;

public struct Shape
{
    internal ShapeType Type { get; init; }
    public float Width { get; init; }
    public float Height { get; init; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float Area() {
        float widthWidth = this.Width * this.Width;
        float widthHeight = this.Height * this.Width;
        switch (this.Type) {
            case ShapeType.Square :
                return widthWidth;                
            case ShapeType.Rectangle:
                return widthHeight;                
            case ShapeType.Triangle:
                return widthHeight * 0.5f;
            case ShapeType.Circle:
                return (float)Math.PI * widthHeight;                
        }
        return 0.0f;
    }
}
