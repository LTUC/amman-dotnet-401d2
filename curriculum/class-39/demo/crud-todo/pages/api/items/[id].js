import { items } from '../items'

export default function userHandler(req, res) {
    const {
        query: { id },
        body: { title, description, completed },
        method,
    } = req

    switch (method) {
        case 'GET':
            // Get data from your database
            const item = items.find(item => parseInt(item.id) === parseInt(id));
            res.status(200).json(item);
            break
        case 'PUT':
            // Update or create data in your database
            const fetchedItem = items.find(item => parseInt(item.id) === parseInt(id));
            fetchedItem.title = title;
            fetchedItem.description = description;
            fetchedItem.completed = completed;
            res.status(200).json(fetchedItem);
            break

        case 'DELETE':
            const index = items.findIndex(item => parseInt(item.id) === parseInt(id));
            items.splice(index, 1);
            res.status(200).json({});
            break;

        default:
            res.setHeader('Allow', ['GET', 'PUT', 'DELETE'])
            res.status(405).end(`Method ${method} Not Allowed`)
    }
}
