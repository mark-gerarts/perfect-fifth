module P5Reference.Math.Asin0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let a = pi / 3.0
    let s = sin a
    /// Use the Trig.* trigonometry functions if you need the angle mode context
    /// of the current p5 instance.
    let s' = Trig.sin p5 a
    let asn = asin s
    // Prints: "1.0471975 : 0.86602540 : 1.0471975"
    print p5 (sprintf "%f : %f : %f" a s asn)

let run node = display node draw
