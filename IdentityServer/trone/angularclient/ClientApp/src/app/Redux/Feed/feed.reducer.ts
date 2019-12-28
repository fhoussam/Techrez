import { Feed } from '../../models/Feed';
import * as FeedActions from './feeds.actions';

const initial_state = { feeds: [] }

export function feedReducer(state = initial_state, action: FeedActions.FeedAction) {
    switch (action.type) {
        case FeedActions.ADD_FEED:
            return {
                ...state,
                feeds: [action.payload, ...state.feeds]
            };
        case FeedActions.LOAD_FEEDS:
            return {
                ...state,
                feeds: action.payload
            };
        default:
            return state;
    }
}