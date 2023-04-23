module P5Reference.Math.P5VectorSub2

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    // Static method
    let v1 = createVector3D 2 3 4
    let v2 = createVector3D 1 2 3

    let v3 = P5Vector.sub (v1, v2)
    // v3 has components [1, 1, 1]
    print p5 (string v3)

let run node = display node draw
