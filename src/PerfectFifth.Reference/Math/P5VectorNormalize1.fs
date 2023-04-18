module P5Reference.Math.P5VectorNormalize1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    // Static method
    let v_initial = P5Vector.create (10, 20, 2)
    // v_initial has components [10.0, 20.0, 2.0]
    let v_normalized = P5Vector.normalize (v_initial)
    // returns a new vector with components set to [0.4454354, 0.8908708, 0.089087084]
    // v_initial remains unchanged
    print p5 (string v_normalized)

let run node = display node draw
