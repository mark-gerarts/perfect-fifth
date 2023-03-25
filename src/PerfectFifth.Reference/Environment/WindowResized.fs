module P5Reference.Environment.WindowResized

open P5.Core
open P5.Color
open P5.Environment
open P5.Rendering

let setup p5 =
    resizeCanvas p5 (windowWidth p5) (windowHeight p5)
    ()

let draw p5 () = background p5 (RGB(0, 100, 200))

let update p5 = id

let onWindowResized p5 _ =
    resizeCanvas p5 (windowWidth p5) (windowHeight p5)

let subscriptions = [ OnWindowResized(Effect onWindowResized) ]

let run node =
    play node setup update draw subscriptions
