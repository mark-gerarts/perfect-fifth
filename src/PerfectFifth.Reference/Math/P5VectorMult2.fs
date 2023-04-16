module P5Reference.Math.P5VectorMult2

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v0 = createVector3D 1 2 3
    // Provide arguments as an array
    let arr = [| 2.0; 3.0; 4.0 |]
    v0.multValues arr // v0's components are set to [2, 6, 12]
    print p5 (string v0)

let run node = display node draw
