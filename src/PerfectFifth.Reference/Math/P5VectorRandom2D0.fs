module P5Reference.Math.P5VectorRandom2D0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.random2D ()
    // May make v's attributes something like:
    // [0.61554617, -0.51195765, 0.0] or
    // [-0.4695841, -0.14366731, 0.0] or
    // [0.6091097, -0.22805278, 0.0]
    print p5 (string v)

let run node = display node draw
