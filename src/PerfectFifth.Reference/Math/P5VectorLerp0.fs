module P5Reference.Math.P5VectorLerp0

open P5.Core
open P5.Math
open P5.Environment

let draw p5 =
    let v = P5Vector.create (1, 1, 0)
    v.lerp (3, 3, 0, 0.5) // v now has components [2,2,0]
    print p5 (string v)

let run node = display node draw
