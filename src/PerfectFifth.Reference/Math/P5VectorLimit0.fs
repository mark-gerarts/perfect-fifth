module P5Reference.Math.P5VectorLimit0

open P5.Core
open P5.Math
open P5.Environment

let draw p5 =
    let v = P5Vector.create (10, 20, 2)
    // v has components [10.0, 20.0, 2.0]
    v.limit 5
    // v's components are set to
    // [2.2271771, 4.4543543, 0.4454354]
    print p5 (string v)

let run node = display node draw
