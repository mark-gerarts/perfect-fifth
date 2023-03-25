module P5Reference.Shape.BezierTangent0

open P5.Core
open P5.Color
open P5.Shape
open P5.Math

let draw p5 =
    noFill p5
    bezier p5 85 20 10 10 90 90 15 80
    fill p5 (Grayscale 255)

    for i in seq { 0..6 } do
        let t = float i / 6.0

        // Get the location of the point
        let x = bezierPoint p5 85 10 90 15 t
        let y = bezierPoint p5 20 10 90 80 t

        // Get the tangent points
        let tx = bezierTangent p5 85 10 90 15 t
        let ty = bezierTangent p5 20 10 90 80 t

        // Calculate an angle from the tangent points
        let a = atan2 ty tx + pi

        stroke p5 (RGB(255, 102, 0))
        line p5 x y (cos a * 30.0 + x) (sin a * 30.0 + y)

        // The following line of code makes a line
        // inverse of the above line
        //line(x, y, cos(a)*-30 + x, sin(a)*-30 + y);
        stroke p5 (Grayscale 0)
        circle p5 x y 5

let run node = display node draw
