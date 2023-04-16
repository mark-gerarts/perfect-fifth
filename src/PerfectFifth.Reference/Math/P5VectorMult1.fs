module P5Reference.Math.P5VectorMult1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v0 = createVector3D 1 2 3
    let v1 = createVector3D 2 3 4
    v0.multVector v1 // v0's components are set to [2, 6, 12]
    print p5 (string v0)

let run node = display node draw
