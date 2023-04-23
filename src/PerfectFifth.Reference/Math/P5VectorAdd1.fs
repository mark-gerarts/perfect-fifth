module P5Reference.Math.P5VectorAdd1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = createVector3D 1 2 3
    // Provide arguments as an array
    let arr = [| 4.0; 5.0; 6.0 |]
    v.addValues (arr)
    print p5 (string v)

let run node = display node draw
