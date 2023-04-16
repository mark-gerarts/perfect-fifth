module P5Reference.Math.P5VectorRem0

open P5.Core
open P5.Math
open P5.Environment

let draw p5 =
    let v = createVector3D 3 4 5
    v.rem (2, 3, 4)
    print p5 (string v)

let run node = display node draw
