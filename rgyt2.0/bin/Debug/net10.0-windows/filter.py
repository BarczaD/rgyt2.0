import dbf
import os
import sys

if len(sys.argv) < 2:
    print("Nincs megadva DBF mappa!")
    exit(1)

base = sys.argv[1]

print("DBF mappa:", base)

# --- gyerek ---
src = dbf.Table(os.path.join(base, "gyerek.dbf"))
src.open()

dst = dbf.Table(
    os.path.join(base, "gyfix.dbf"),
    src.structure(),
    codepage='cp1250'
)
dst.open(mode=dbf.READ_WRITE)

for rec in src:
    if not dbf.is_deleted(rec):
        dst.append(rec)

src.close()
dst.close()

print("gyfix kész")

# --- szulok ---
src = dbf.Table(os.path.join(base, "szulok.dbf"))
src.open()

dst = dbf.Table(
    os.path.join(base, "szfix.dbf"),
    src.structure(),
    codepage='cp1250'
)
dst.open(mode=dbf.READ_WRITE)

for rec in src:
    if not dbf.is_deleted(rec):
        dst.append(rec)

src.close()
dst.close()

print("szfix kész")