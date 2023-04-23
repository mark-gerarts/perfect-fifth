module P5Reference.Math.P5VectorRotate1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    // static function implementation
    let v = P5Vector.create (10.0, 20.0)
    // v has components [10.0, 20.0, 0.0]
    let rotated_v = P5Vector.rotate (v, halfPi)

    // rotated_v's components are set to [-20.0, 9.999999, 0.0]
    print p5 (string rotated_v)

    // v's components remains the same (i.e, [10.0, 20.0, 0.0])
    print p5 (string v)

let run node = display node draw
