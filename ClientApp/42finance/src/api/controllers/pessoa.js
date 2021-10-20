import util from '../util'

let controller = 'Pessoa'

export default Object.assign({}, util.Axios.GetCrud(controller, ['get', 'getall', 'post', 'delete']))