module P5Reference.Math.P5VectorDist0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (1, 0, 0)
    let v2 = P5Vector.create (0, 1, 0)

    let distance = v1.dist (v2) // distance is 1.4142...
    print p5 (string distance)

let run node = display node draw
