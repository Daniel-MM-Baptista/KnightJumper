public class MathUtils{
    public float findSlope(float x1, float x2, float y1, float y2){
        return (y2-y1)/(x2-x1);
    }

    public float findOriginPoint(float slope, float x1, float y1){
        return y1-(slope*x1);
    }
}