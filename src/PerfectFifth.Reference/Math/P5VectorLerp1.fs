module P5Reference.Math.P5VectorLerp1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (0, 0, 0)
    let v2 = P5Vector.create (100, 100, 0)

    let v3 = P5Vector.lerp (v1, v2, 0.5)
    // v3 has components [50,50,0]
    print p5 (string v3)

let run node = display node draw
