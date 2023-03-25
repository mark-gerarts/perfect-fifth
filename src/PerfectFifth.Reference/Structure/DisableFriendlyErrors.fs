module P5Reference.Structure.DisableFriendlyErrors

open P5.Core
open P5.Color

let draw (p5: P5) =
    p5.disableFriendlyErrors <- true
    background p5 (Name "green")

let run node = display node draw
