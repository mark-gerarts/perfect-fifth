module P5Reference.Math.P5VectorDiv1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v0 = createVector3D 9 4 2
    let v1 = createVector3D 3 2 4
    v0.divVector v1
    print p5 (string v0)

let run node = display node draw
