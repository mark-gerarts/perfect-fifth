module P5Reference.Math.P5VectorSet0

open P5.Core
open P5.Math

let draw p5 =
    let v = createVector3D 1 2 3
    v.set (4, 5, 6) // Sets vector to [4, 5, 6]

    let v1 = createVector3D 0 0 0
    let arr = [| 1.0; 2.0; 3.0 |]
    v1.setFromValues arr // Sets vector to [1, 2, 3]

let run node = display node draw
