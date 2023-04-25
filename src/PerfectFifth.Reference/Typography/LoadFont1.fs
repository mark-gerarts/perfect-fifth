module P5Reference.Typography.LoadFont1

open P5.Core
open P5.Color
open P5.Typography

let drawText p5 font =
    fill p5 (Name "#ED225D")
    setTextFontWithSize p5 font 36
    text p5 "p5*js" 10 50

let setup p5 =
    let onSuccess = drawText p5
    let onError = fun _ -> ()
    loadFontWithCallbacks p5 "assets/inconsolata.otf" onSuccess onError

let draw _ _ = ()

let run node = animate node setup draw
