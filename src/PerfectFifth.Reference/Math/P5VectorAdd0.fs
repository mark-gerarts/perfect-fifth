module P5Reference.Math.P5VectorAdd0

open P5.Core
open P5.Math
open P5.Environment

let draw p5 =
    let v = createVector3D 1 2 3
    v.add (4, 5, 6)
    print p5 (string v)

let run node = display node draw
