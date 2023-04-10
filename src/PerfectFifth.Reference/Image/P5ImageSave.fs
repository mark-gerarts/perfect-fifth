module P5Reference.Image.P5ImageSave

open P5.Core
open P5.Image
open P5.Events

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 (photo: P5Image) = image p5 photo 0 0

let onKeyTyped p5 _ (photo: P5Image) =
    match key p5 with
    | "s" -> photo.save "photo" "png"
    | _ -> ()

    photo

let subscriptions = [ OnKeyTyped(Update onKeyTyped) ]

let run node =
    playWithPreload node preload noUpdate noUpdate draw subscriptions
