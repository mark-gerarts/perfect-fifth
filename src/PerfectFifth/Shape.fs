namespace P5

module Shape =

    open Fable.Core
    open P5.Core
    open Math

    type ArcMode =
        | Chord
        | Pie
        | Open

    let private rawArcMode mode =
        match mode with
        | Chord -> "chord"
        | Pie -> "pie"
        | Open -> "open"

    [<Emit("$0.smooth()")>]
    let smooth (p5: P5) : Unit = jsNative

    [<Emit("$0.noSmooth()")>]
    let noSmooth (p5: P5) : Unit = jsNative

    [<Emit("$0.arc($1, $2, $3, $4, $5, $6)")>]
    let arc (p5: P5) (x: float) (y: float) (w: float) (h: float) (start: float) (stop: float) : Unit = jsNative

    [<Emit("$0.arc($1, $2, $3, $4, $5, $6, $7, $8)")>]
    let private arc_
        (p5: P5)
        (x: float)
        (y: float)
        (w: float)
        (h: float)
        (start: float)
        (stop: float)
        (mode: string)
        (detail: int)
        : Unit =
        jsNative

    let arcWithMode
        (p5: P5)
        (x: float)
        (y: float)
        (w: float)
        (h: float)
        (start: float)
        (stop: float)
        (mode: ArcMode)
        : Unit =
        arc_ p5 x y w h start stop (rawArcMode mode) 25

    let arcWithDetail
        (p5: P5)
        (x: float)
        (y: float)
        (w: float)
        (h: float)
        (start: float)
        (stop: float)
        (mode: ArcMode)
        (detail: int)
        : Unit =
        arc_ p5 x y w h start stop (rawArcMode mode) detail

    /// TODO: point with vector
    [<Emit("$0.point($1, $2)")>]
    let point2D (p5: P5) (x: float) (y: float) : Unit = jsNative

    let point = point2D

    [<Emit("$0.point($1, $2)")>]
    let point3D (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    [<Emit("$0.point($1)")>]
    let pointFromVector (p5: P5) (vector: P5Vector) : Unit = jsNative

    [<Emit("$0.line($1, $2, $3, $4)")>]
    let line2D (p5: P5) (x1: float) (y1: float) (x2: float) (y2: float) : Unit = jsNative

    [<Emit("$0.line($1, $2, $3, $4, $5, $6)")>]
    let line3D (p5: P5) (x1: float) (y1: float) (z1: float) (x2: float) (y2: float) (z2: float) : Unit = jsNative

    let line = line2D

    [<Emit("$0.rect($1, $2, $3, $4)")>]
    let rect (p5: P5) (x: float) (y: float) (w: float) (h: float) : Unit = jsNative

    [<Emit("$0.rect($1, $2, $3, $4, $5, $6)")>]
    let rectWithDetail (p5: P5) (x: float) (y: float) (w: float) (h: float) (detailX: int) (detailY: int) : Unit =
        jsNative

    [<Emit("$0.rect($1, $2, $3, $4, $5, $6, $7, $8)")>]
    let roundedRect
        (p5: P5)
        (x: float)
        (y: float)
        (w: float)
        (h: float)
        (tl: float)
        (tr: float)
        (bl: float)
        (br: float)
        : Unit =
        jsNative

    [<Emit("$0.square($1, $2, $3)")>]
    let square (p5: P5) (x: float) (y: float) (s: float) : Unit = jsNative

    [<Emit("$0.square($1, $2, $3, $4, $5, $6, $7)")>]
    let roundedSquare (p5: P5) (x: float) (y: float) (s: float) (tl: float) (tr: float) (bl: float) (br: float) : Unit =
        jsNative

    [<Emit("$0.triangle($1, $2, $3, $4, $5, $6)")>]
    let triangle (p5: P5) (x1: float) (y1: float) (x2: float) (y2: float) (x3: float) (y3: float) : Unit = jsNative

    [<Emit("$0.ellipse($1, $2, $3, $4)")>]
    let ellipse (p5: P5) (x: float) (y: float) (w: float) (h: float) : Unit = jsNative

    [<Emit("$0.ellipse($1, $2, $3, $4, $5)")>]
    let ellipseDetail (p5: P5) (x: float) (y: float) (w: float) (h: float) (detail: int) : Unit = jsNative

    [<Emit("$0.circle($1, $2, $3)")>]
    let circle (p5: P5) (x: float) (y: float) (d: float) : Unit = jsNative

    [<Emit("$0.quad($1, $2, $3, $4, $5, $6, $7, $8)")>]
    let quad
        (p5: P5)
        (x1: float)
        (y1: float)
        (x2: float)
        (y2: float)
        (x3: float)
        (y3: float)
        (x4: float)
        (y4: float)
        : Unit =
        jsNative

    [<Emit("$0.quad($1, $2, $3, $4, $5, $6, $7, $8, $9, $10)")>]
    let quadWithDetail
        (p5: P5)
        (x1: float)
        (y1: float)
        (x2: float)
        (y2: float)
        (x3: float)
        (y3: float)
        (x4: float)
        (y4: float)
        (detailX: int)
        (detailY: int)
        : Unit =
        jsNative

    [<Emit("$0.quad($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12)")>]
    let quad3D
        (p5: P5)
        (x1: float)
        (y1: float)
        (z1: float)
        (x2: float)
        (y2: float)
        (z2: float)
        (x3: float)
        (y3: float)
        (z3: float)
        (x4: float)
        (y4: float)
        (z4: float)
        : Unit =
        jsNative

    [<Emit("$0.quad($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12, $13, $14)")>]
    let quad3DWithDetail
        (p5: P5)
        (x1: float)
        (y1: float)
        (z1: float)
        (x2: float)
        (y2: float)
        (z2: float)
        (x3: float)
        (y3: float)
        (z3: float)
        (x4: float)
        (y4: float)
        (z4: float)
        (detailX: int)
        (detailY: int)
        : Unit =
        jsNative

    [<Emit("$0.plane($1, $2)")>]
    let plane (p5: P5) (width: float) (height: float) : Unit = jsNative

    [<Emit("$0.plane($1, $2, $3, $4)")>]
    let planeWithDetail (p5: P5) (width: float) (height: float) (detailX: float) (detailY: float) : Unit = jsNative

    [<Emit("$0.plane()")>]
    let planeWithDefaults (p5: P5) : Unit = jsNative

    [<Emit("$0.box($1, $2, $3)")>]
    let box (p5: P5) (width: float) (height: float) (depth: float) : Unit = jsNative

    [<Emit("$0.box($1)")>]
    let cube (p5: P5) (width: float) : Unit = jsNative

    [<Emit("$0.box($1, $2, $3, $4, $5)")>]
    let boxWithDetail (p5: P5) (width: float) (height: float) (depth: float) (detailX: float) (detailY: float) : Unit =
        jsNative

    [<Emit("$0.sphere($1)")>]
    let sphere (p5: P5) (radius: float) : Unit = jsNative

    [<Emit("$0.sphere($1, $2, $3)")>]
    let sphereWithDetail (p5: P5) (radius: float) (detailX: float) (detailY: float) : Unit = jsNative

    [<Emit("$0.cylinder($1, $2)")>]
    let cylinder (p5: P5) (radius: float) (height: float) : Unit = jsNative

    [<Emit("$0.cylinder()")>]
    let cylinderWithDefaults (p5: P5) : Unit = jsNative

    [<Emit("$0.cylinder($1, $2, $3, $4)")>]
    let cylinderWithDetail (p5: P5) (radius: float) (height: float) (detailX: float) (detailY: float) : Unit = jsNative

    [<Emit("$0.cylinder($1, $2, $3, $4, $5, $6)")>]
    let cylinderWithDetailAndCap
        (p5: P5)
        (radius: float)
        (height: float)
        (detailX: float)
        (detailY: float)
        (bottomCap: bool)
        (topCap: bool)
        : Unit =
        jsNative

    [<Emit("$0.cone($1, $2)")>]
    let cone (p5: P5) (radius: float) (height: float) : Unit = jsNative

    [<Emit("$0.cone()")>]
    let coneWithDefaults (p5: P5) : Unit = jsNative

    [<Emit("$0.cone($1, $2, $3, $4)")>]
    let coneWithDetail (p5: P5) (radius: float) (height: float) (detailX: float) (detailY: float) : Unit = jsNative

    [<Emit("$0.cone($1, $2, $3, $4, $5)")>]
    let coneWithDetailAndCap
        (p5: P5)
        (radius: float)
        (height: float)
        (detailX: float)
        (detailY: float)
        (cap: bool)
        : Unit =
        jsNative

    [<Emit("$0.ellipsoid($1, $2, $3)")>]
    let ellipsoid (p5: P5) (radiusX: float) (radiusY: float) (radiusZ: float) : Unit = jsNative

    [<Emit("$0.ellipsoid()")>]
    let ellipsoidWithDefaults (p5: P5) : Unit = jsNative

    [<Emit("$0.ellipsoid($1, $2, $3, $4, $5)")>]
    let ellipsoidWithDetail
        (p5: P5)
        (radiusX: float)
        (radiusY: float)
        (radiusZ: float)
        (detailX: float)
        (detailY: float)
        : Unit =
        jsNative

    [<Emit("$0.torus($1, $2)")>]
    let torus (p5: P5) (radius: float) (tubeRadius: float) : Unit = jsNative

    [<Emit("$0.torus()")>]
    let torusWithDefaults (p5: P5) : Unit = jsNative

    [<Emit("$0.torus($1, $2, $3, $4)")>]
    let torusWithDetail (p5: P5) (radius: float) (tubeRadius: float) (detailX: float) (detailY: float) : Unit = jsNative

    type DrawMode =
        | Center
        | Radius
        | Corner
        | Corners

    let private rawDrawMode (mode: DrawMode) : string =
        match mode with
        | Center -> "center"
        | Radius -> "radius"
        | Corner -> "corner"
        | Corners -> "corners"

    [<Emit("$0.ellipseMode($1)")>]
    let private ellipseMode_ (p5: P5) (mode: string) : Unit = jsNative

    let ellipseMode (p5: P5) (mode: DrawMode) : Unit = ellipseMode_ p5 (rawDrawMode mode)

    [<Emit("$0.rectMode($1)")>]
    let private rectMode_ (p5: P5) (mode: string) : Unit = jsNative

    let rectMode (p5: P5) (mode: DrawMode) : Unit = rectMode_ p5 (rawDrawMode mode)

    type Cap =
        | CapRound
        | CapSquare
        | CapProject

    let private rawCap (cap: Cap) : string =
        match cap with
        | CapRound -> "round"
        | CapSquare -> "butt"
        | CapProject -> "square"

    [<Emit("$0.strokeCap($1)")>]
    let private strokeCap_ (p5: P5) (cap: string) : Unit = jsNative

    let strokeCap (p5: P5) (cap: Cap) : Unit = strokeCap_ p5 (rawCap cap)

    type Join =
        | JoinMiter
        | JoinBevel
        | JoinRound

    let private rawJoin (join: Join) : string =
        match join with
        | JoinMiter -> "miter"
        | JoinBevel -> "bevel"
        | JoinRound -> "round"

    [<Emit("$0.strokeJoin($1)")>]
    let private strokeJoin_ (p5: P5) (join: string) : Unit = jsNative

    let strokeJoin (p5: P5) (join: Join) : Unit = strokeJoin_ p5 (rawJoin join)

    [<Emit("$0.strokeWeight($1)")>]
    let strokeWeight (p5: P5) (weight: float) : Unit = jsNative

    /// TODO: uv
    [<Emit("$0.vertex($1, $2)")>]
    let vertex (p5: P5) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.vertex($1, $2, $3)")>]
    let vertex3D (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    [<Emit("$0.vertex($1, $2, $3, $4, $5)")>]
    let vertexWithTexture (p5: P5) (x: float) (y: float) (z: float) (u: float) (v: float) = jsNative

    [<Emit("$0.bezierVertex($1, $2, $3, $4, $5, $6)")>]
    let bezierVertex (p5: P5) (x2: float) (y2: float) (x3: float) (y3: float) (x4: float) (y4: float) : Unit = jsNative

    [<Emit("$0.bezierVertex($1, $2, $3, $4, $5, $6, $7, $8, $9)")>]
    let bezierVertex3D
        (p5: P5)
        (x2: float)
        (y2: float)
        (z2: float)
        (x3: float)
        (y3: float)
        (z3: float)
        (x4: float)
        (y4: float)
        (z4: float)
        : Unit =
        jsNative

    [<Emit("$0.curveVertex($1, $2)")>]
    let curveVertex (p5: P5) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.curveVertex($1, $2, $3)")>]
    let curveVertex3D (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    [<Emit("$0.quadraticVertex($1, $2, $3, $4)")>]
    let quadraticVertex (p5: P5) (cx: float) (cy: float) (x3: float) (y3: float) : Unit = jsNative

    [<Emit("$0.quadraticVertex($1, $2, $3, $4, $5, $6)")>]
    let quadraticVertex3D (p5: P5) (cx: float) (cy: float) (cz: float) (x3: float) (y3: float) (z3: float) : Unit =
        jsNative

    [<Emit("$0.bezier($1, $2, $3, $4, $5, $6, $7, $8)")>]
    let bezier
        (p5: P5)
        (x1: float)
        (y1: float)
        (x2: float)
        (y2: float)
        (x3: float)
        (y3: float)
        (x4: float)
        (y4: float)
        : Unit =
        jsNative

    [<Emit("$0.bezier($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12)")>]
    let bezier3D
        (p5: P5)
        (x1: float)
        (y1: float)
        (z1: float)
        (x2: float)
        (y2: float)
        (z2: float)
        (x3: float)
        (y3: float)
        (z3: float)
        (x4: float)
        (y4: float)
        (z4: float)
        : Unit =
        jsNative

    [<Emit("$0.bezierDetail($1)")>]
    let bezierDetail (p5: P5) (detail: float) : Unit = jsNative

    [<Emit("$0.bezierPoint($1, $2, $3, $4, $5)")>]
    let bezierPoint (p5: P5) (a: float) (b: float) (c: float) (d: float) (t: float) : float = jsNative

    [<Emit("$0.bezierTangent($1, $2, $3, $4, $5)")>]
    let bezierTangent (p5: P5) (a: float) (b: float) (c: float) (d: float) (t: float) : float = jsNative


    [<Emit("$0.curve($1, $2, $3, $4, $5, $6, $7, $8)")>]
    let curve
        (p5: P5)
        (x1: float)
        (y1: float)
        (x2: float)
        (y2: float)
        (x3: float)
        (y3: float)
        (x4: float)
        (y4: float)
        : Unit =
        jsNative

    [<Emit("$0.curve($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12)")>]
    let curve3D
        (p5: P5)
        (x1: float)
        (y1: float)
        (z1: float)
        (x2: float)
        (y2: float)
        (z2: float)
        (x3: float)
        (y3: float)
        (z3: float)
        (x4: float)
        (y4: float)
        (z4: float)
        : Unit =
        jsNative

    [<Emit("$0.curveDetail($1)")>]
    let curveDetail (p5: P5) (resolution: float) : Unit = jsNative

    [<Emit("$0.curveTightness($1)")>]
    let curveTightness (p5: P5) (amount: float) : Unit = jsNative

    [<Emit("$0.curvePoint($1, $2, $3, $4, $5)")>]
    let curvePoint (p5: P5) (a: float) (b: float) (c: float) (d: float) (t: float) : float = jsNative

    [<Emit("$0.curveTangent($1, $2, $3, $4, $5)")>]
    let curveTangent (p5: P5) (a: float) (b: float) (c: float) (d: float) (t: float) : float = jsNative

    [<Emit("$0.beginContour()")>]
    let beginContour (p5: P5) : Unit = jsNative

    [<Emit("$0.endContour()")>]
    let endContour (p5: P5) : Unit = jsNative

    type ShapeMode =
        | Points
        | Lines
        | Triangles
        | TriangleFan
        | TriangleStrip
        | Quads
        | QuadStrip
        | Tess

    type private RawShapeMode =
        | RawInt of int
        | RawString of string

    let private rawShapeMode mode =
        match mode with
        | Points -> RawInt 0
        | Lines -> RawInt 1
        | Triangles -> RawInt 4
        | TriangleFan -> RawInt 6
        | TriangleStrip -> RawInt 5
        | Quads -> RawString "quads"
        | QuadStrip -> RawString "quad_strip"
        | Tess -> RawString "tess"

    [<Emit("$0.beginShape()")>]
    let beginShape (p5: P5) : Unit = jsNative

    [<Emit("$0.beginShape($1)")>]
    let private beginShapeWithModeInt_ (p5: P5) (mode: int) : Unit = jsNative

    [<Emit("$0.beginShape($1)")>]
    let private beginShapeWithModeString_ (p5: P5) (mode: string) : Unit = jsNative

    let beginShapeWithMode (p5: P5) (mode: ShapeMode) : Unit =
        match rawShapeMode mode with
        | RawInt i -> beginShapeWithModeInt_ p5 i
        | RawString s -> beginShapeWithModeString_ p5 s

    [<Emit("$0.endShape()")>]
    let endShape (p5: P5) : Unit = jsNative

    [<Emit("$0.endShape('close')")>]
    let endShapeAndClose (p5: P5) : Unit = jsNative

    [<Emit("$0.normal($1, $2, $3)")>]
    let normal (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    [<Emit("$0.normal($1)")>]
    let normalFromVector (p5: P5) (v: P5Vector) : Unit = jsNative

    type P5Geometry =
        [<Emit("$0.computeFaces()")>]
        member _.computeFaces() : Unit = jsNative

        [<Emit("$0.computeNormals()")>]
        member _.computeNormals() : Unit = jsNative

        [<Emit("$0.averageNormals()")>]
        member _.averageNormals() : Unit = jsNative

        [<Emit("$0.averagePoleNormals()")>]
        member _.averagePoleNormals() : Unit = jsNative

        [<Emit("$0.normalize()")>]
        member _.normalize() : Unit = jsNative

    [<Emit("$0.loadModel($1, $2)")>]
    let loadModel (p5: P5) (path: string) (normalize: bool) : P5Geometry = jsNative

    [<Emit("$0.loadModel($1, $2, $3, $4)")>]
    let loadModelWithCallbacks
        (p5: P5)
        (path: string)
        (normalize: bool)
        (onSuccess: P5Geometry -> Unit)
        (onError: obj -> Unit)
        : P5Geometry =
        jsNative

    [<Emit("$0.loadModel($1, $2, $3, $4, $5)")>]
    let loadModelWithCallbacksAndFileType
        (p5: P5)
        (path: string)
        (normalize: bool)
        (onSuccess: P5Geometry -> Unit)
        (onError: obj -> Unit)
        (fileType: string)
        : P5Geometry =
        jsNative

    [<Emit("$0.model($1)")>]
    let model (p5: P5) (model: P5Geometry) : Unit = jsNative
