import shutil as sh
import os
import yaml

basedir = os.path.dirname(os.path.realpath(__file__))

with open(f"{basedir}/site.yaml", "r") as stream:
    site_structure = yaml.safe_load(stream)

if os.path.exists(f"{basedir}/output"):
    sh.rmtree(f"{basedir}/output")

os.mkdir(f"{basedir}/output")

sh.copyfile(f"{basedir}/index.html", f"{basedir}/output/index.html")
sh.copyfile(f"{basedir}/examples.html", f"{basedir}/output/examples.html")


def to_filename(section, entry_name):
    entry_name = entry_name.replace(" ", "-")

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
for section, entries in site_structure["examples"].items():
    for file, name in entries.items():
        filename = to_filename(section, name)
        src = f"{basedir}/example.html"
        dst = f"{basedir}/output/{filename}"

        sh.copyfile(src, dst)

        title = f"{section} - {name}"
        replace_in_file(dst, "$title", title)

        replace_in_file(dst, "$file", file)
        replace_in_file(dst, "$escapedFile", file.replace("/", "%2F"))

        p5js_link = f"https://p5js.org/examples/{filename}"
        replace_in_file(dst, "$p5jsLink", p5js_link)

# Create listing of pages for examples.
example_list = ""
for section, entries in site_structure["examples"].items():
    example_list += f"<h3>{section}</h3>"
    example_list += "<ul>"
    for name in entries.values():
        link = to_filename(section, name)
        example_list += f'<li><a href="{link}">{name}</a></li>'
    example_list += "</ul>"
example_list += ""

replace_in_file(f"{basedir}/output/examples.html", "$exampleList", example_list)
