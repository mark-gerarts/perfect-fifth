module P5Reference.Math.P5VectorCross0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (1, 2, 3)
    let v2 = P5Vector.create (1, 2, 3)

    let v = v1.cross (v2) // v's components are [0, 0, 0]
    print p5 (string v)

let run node = display node draw
