# Upload

```
k6 run k6/upload.js
```

# Generate file

```
# 1M
mkfile -n 1048576  input/input1m.bin
mkfile -n 1048577  input/input1x.bin

# 30M
mkfile -n 31457280 input/input30m.bin
mkfile -n 31457281 input/input30x.bin

ls -alh  input
```