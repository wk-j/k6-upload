import http from 'k6/http';
import { check } from 'k6';
import { FormData } from 'https://jslib.k6.io/formdata/0.0.2/index.js';

const img1 = open('../README.md', 'b');

export default function () {
    const fd = new FormData();
    fd.append('Id', 'someValue');
    fd.append('File', http.file(img1, 'image1.png', 'image/png'));

    const res = http.post('http://localhost:5170/api/upload/upload', fd.body(), {
        headers: { 'Content-Type': 'multipart/form-data; boundary=' + fd.boundary },
    });

    check(res, {
        'is status 200': (r) => r.status === 200,
    });

    if (res.status != 200) {
        console.log(res.body)
    }
}