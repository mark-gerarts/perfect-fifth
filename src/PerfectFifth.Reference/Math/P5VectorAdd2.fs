module P5Reference.Math.P5VectorAdd2

open P5.Core
open P5.Math
open P5.Environment

let draw p5 =
    // Static method
    let v1 = P5Vector.create (1, 2, 3)
    let v2 = P5Vector.create (2, 3, 4)

    let v3 = P5Vector.add (v1, v2)
    // v3 has components [3, 5, 7]
    print p5 (string v3)

let run node = display node draw
