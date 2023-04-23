module P5Reference.Math.Acos0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let a = pi
    /// F# has trigonometry built-in.
    let c = cos a
    /// Use the Trig.* trigonometry functions if you need the angle mode context
    /// of the current p5 instance.
    let c' = Trig.cos p5 a
    let ac = acos c
    // Prints: "3.1415927 : -1.0 : 3.1415927"
    print p5 (sprintf "%f : %f : %f" a c ac)

let run node = display node draw
