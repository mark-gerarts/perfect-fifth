module P5Reference.Math.P5VectorNormalize0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (10, 20, 2)
    // v has components [10.0, 20.0, 2.0]
    v.normalize ()
    // v's components are set to [0.4454354, 0.8908708, 0.089087084]
    print p5 (string v)

let run node = display node draw
