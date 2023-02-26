import shutil as sh
import os

structure = {
    "Structure": [
        {"name": "Coordinates", "file": "Structure/Coordinates"},
        {"name": "Width and Height", "file": "Structure/WidthAndHeight"},
        {"name": "Setup and Draw", "file": "Structure/SetupAndDraw"},
        {"name": "No Loop", "file": "Structure/NoLoop"},
        {"name": "Loop", "file": "Structure/Loop"},
        {"name": "Redraw", "file": "Structure/Redraw"},
        {"name": "Functions", "file": "Structure/Functions"},
    ],
    "Form": [
        {"name": "Points and Lines", "file": "Form/PointsAndLines"},
    ],
}

basedir = os.path.dirname(os.path.realpath(__file__))

if os.path.exists(f"{basedir}/output"):
    sh.rmtree(f"{basedir}/output")

os.mkdir(f"{basedir}/output")

sh.copyfile(f"{basedir}/index.html", f"{basedir}/output/index.html")
sh.copyfile(f"{basedir}/examples.html", f"{basedir}/output/examples.html")


def to_filename(section, entry):
    entry_name = entry["name"].replace(" ", "-")

    return f"{section}-{entry_name}.html".lower()


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

        p5js_link = f"https://p5js.org/examples/{filename}"
        replace_in_file(dst, "$p5jsLink", p5js_link)

# Create listing of pages for examples.
example_list = ""
for section, entries in structure.items():
    example_list += f"<h3>{section}</h3>"
    example_list += "<ul>"
    for entry in entries:
        entry_name = entry["name"]
        link = to_filename(section, entry)
        example_list += f'<li><a href="{link}">{entry_name}</a></li>'
    example_list += "</ul>"
example_list += ""

replace_in_file(f"{basedir}/output/examples.html", "$exampleList", example_list)
