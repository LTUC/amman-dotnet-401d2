// Next.js API route support: https://nextjs.org/docs/api-routes/introduction

export const items = [
    { id: 0, title: 'get milk', description: 'cow and oat', completed: false },
    { id: 1, title: 'cut hair', description: 'little off the top', completed: true },
    { id: 2, title: 'dance', description: 'the robot', completed: true },
    { id: 3, title: 'mow lawn', description: 'maybe edge too', completed: false },
];

let nextIndex = 4;

export default function itemsAPI(req, res) {


    if (req.method === 'GET') {
        res.status(200).json(items)
    } else if (req.method === 'POST') {
        req.body.id = nextIndex;
        nextIndex += 1;
        items.push(req.body);
        res.status(200).json(200);
    }
}
