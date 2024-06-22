interface IShape {
    public float Area();
}

public class Square : IShape {

    float sideLength;

    public Square(float sideLength) {
        this.sideLength = sideLength;
    }

    public float Area() {
        return sideLength * sideLength;
    }
}

class Rectangle : IShape {
    float width;
    float height;

    public Rectangle(float width, float height) {
        this.width = width;
        this.height = height;
    }

    public float Area() {
        return width * height;
    }
}

class Triangle : IShape {
    float baseLength;
    float height;

    public Triangle(float baseLength, float height) {
        this.baseLength = baseLength;
        this.height = height;
    }

    public float Area() {
        return 0.5f * baseLength * height;
    }
}

class Circle : IShape {
    float radius;

    public Circle(float radius) {
        this.radius = radius;
    }

    public float Area() {
        return (float)Math.PI * radius * radius;
    }
}
