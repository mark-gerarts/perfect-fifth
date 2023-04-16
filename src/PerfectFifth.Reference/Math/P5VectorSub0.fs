module P5Reference.Math.P5VectorSub0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (4, 5, 6)
    v.sub (1, 1, 1)
    print p5 (string v)

let run node = display node draw
