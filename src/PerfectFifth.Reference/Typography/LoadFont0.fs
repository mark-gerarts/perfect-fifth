module P5Reference.Typography.LoadFont0

open P5.Core
open P5.Color
open P5.Typography

let preload p5 = loadFont p5 "assets/inconsolata.otf"

let draw p5 font =
    fill p5 (Name "#ED225D")
    setTextFont p5 font
    setTextSize p5 36
    text p5 "p5*js" 10 50

let run node = displayWithPreload node preload draw
