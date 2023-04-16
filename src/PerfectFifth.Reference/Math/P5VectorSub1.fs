module P5Reference.Math.P5VectorSub1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = createVector3D 4 5 6
    // Provide arguments as an array
    let arr = [| 1.0; 1.0; 1.0 |]
    v.subValues (arr)
    print p5 (string v)

let run node = display node draw
