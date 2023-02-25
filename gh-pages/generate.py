import shutil as sh
import os

structure = {
    "Structure": [
        {
            "name": "Coordinates",
            "file": "Structure/Coordinates",
            "p5js_link": "https://p5js.org/examples/structure-coordinates.html"
        }
    ]
}

basedir = os.path.dirname(os.path.realpath(__file__))

if os.path.exists(f"{basedir}/output"):
    sh.rmtree(f"{basedir}/output")

os.mkdir(f"{basedir}/output")

sh.copyfile(f"{basedir}/index.html", f"{basedir}/output/index.html")
sh.copyfile(f"{basedir}/examples.html", f"{basedir}/output/examples.html")

def to_filename(section, entry):
    entry_name = entry["name"]

    return f"examples-{section}-{entry_name}.html".lower()

def replace_in_file(path, search, replace):
    file_in = open(path, "rt")
    data = file_in.read()
    data = data.replace(search, replace)
    file_in.close()

    file_out = open(path, "wt")
    file_out.write(data)
    file_out.close()


# Create separate pages for examples.
for section, entries in structure.items():
    for entry in entries:
        filename = to_filename(section, entry)
        src = f"{basedir}/example.html"
        dst = f"{basedir}/output/{filename}"

        sh.copyfile(src, dst)

        name = entry["name"]
        title = f"{section} - {name}"
        replace_in_file(dst, "$title", title)

        replace_in_file(dst, "$file", entry["file"])
        replace_in_file(dst, "$escapedFile", entry["file"].replace("/", "%2F"))
        replace_in_file(dst, "$p5jsLink", entry["p5js_link"])

example_list = "<ul>"
# Create listing of pages for examples.
for section, entries in structure.items():
    example_list += f"<li>{section}<ul>"
    for entry in entries:
        entry_name = entry["name"]
        link = to_filename(section, entry)
        example_list += f"<li><a href=\"{link}\">{entry_name}</a></li>"
    example_list += "</ul></li>"
example_list += "</ul>"

replace_in_file(f"{basedir}/output/examples.html", "$exampleList", example_list)
