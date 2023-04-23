module P5Reference.Math.P5VectorCopy

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = createVector3D 1 2 3
    let v2 = v1.copy ()
    // Or:
    // let v2 = P5Vector.copy (v1)
    print p5 (string (v1.x = v2.x && v1.y = v2.y && v1.z = v2.z))

let run node = display node draw
