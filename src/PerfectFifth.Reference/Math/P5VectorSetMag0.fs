module P5Reference.Math.P5VectorSetMag0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (3, 4, 0)
    // v has components [3.0, 4.0, 0.0]
    v.setMag 10
    // v's components are set to [6.0, 8.0, 0.0]
    print p5 (string v)

let run node = display node draw
