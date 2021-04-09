module FileSystem
open System.IO

let dir path = Path.GetDirectoryName(path:string)
let filename path = Path.GetFileNameWithoutExtension(path: string)
let existdir path = Directory.Exists(path)
let mkdir path = Directory.CreateDirectory(path) |> ignore
let (</>) x y = Path.Combine(x,y)
