module P5Reference.Math.P5VectorDiv2

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v0 = createVector3D 9 4 2
    // Provide arguments as an array
    let arr = [| 3.0; 2.0; 4.0 |]
    v0.divValues arr
    print p5 (string v0)

let run node = display node draw
